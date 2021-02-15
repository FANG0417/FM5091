from datetime import timedelta

class FundamentalFactorAlphaModel(AlphaModel):
    
    
    def __init__(self, num_fine, value_weight, solvency_weight, safety_weight):
        
        # Initialize the various variables/helpers we'll need
        self.lastMonth = -1
        self.longs = []
        self.num_fine = num_fine
        self.period = timedelta(31)
        
        # normalize quality, value, size weights
        weights = [value_weight, solvency_weight, safety_weight]
        weights = [float(i)/sum(weights) for i in weights]
        
        self.value_weight = weights[0]
        self.solvency_weight = weights[1]
        self.safety_weight = weights[2]



    def Update(self, algorithm, data):
        '''Updates this alpha model with the latest data from the algorithm.
        This is called each time the algorithm receives data for subscribed securities
        Args:
            algorithm: The algorithm instance
            data: The newa available
        Returns:
            New insights'''
        
        # Return no insights if it's not time to rebalance
        if algorithm.Time.month == self.lastMonth: 
            return []
        self.lastMonth = algorithm.Time.month
        
        # List of insights
        # Insights of the form: Insight(symbol, timedelta, type, direction, magnitude, confidence, sourceModel, weight)
        insights = []
        
        # Close old positions if they aren't in longs
        for security in algorithm.Portfolio.Values:
            if security.Invested and security.Symbol not in self.longs:
                insights.append(Insight(security.Symbol, self.period, InsightType.Price, 
                                            InsightDirection.Flat, None, None, None, None))
        
        length = len(self.longs)
        
        for i in range(length):
            insights.append(Insight(self.longs[i], self.period, InsightType.Price, 
                                    InsightDirection.Up, None, (length - i)**2, None, (length - i)**2 ))
        
        return insights



    def OnSecuritiesChanged(self, algorithm, changes):
        '''Event fired each time the we add/remove securities from the data feed
        Args:
            algorithm: The algorithm instance that experienced the change in securities
            changes: The security additions and removals from the algorithm'''

        # Get the added securities
        added = [x for x in changes.AddedSecurities]
        
        # Assign quality, value, size score to each stock
                
        value_scores = self.Scores(added, [ (lambda x: x.Fundamentals.ValuationRatios.EVToEBITDA, True, 1),
                                            (lambda x: x.Fundamentals.ValuationRatios.PBRatio, True, 1), 
                                            (lambda x: x.Fundamentals.ValuationRatios.PERatio, True, 1),
                                            (lambda x: x.Fundamentals.ValuationRatios.PricetoEBITDA, True, 1),
                                            (lambda x: x.Fundamentals.ValuationRatios.PSRatio, True, 1)])
        
        solvency_scores = self.Scores(added, [ (lambda x: x.Fundamentals.OperationRatios.CashRatio.ThreeMonths, True, 1), 
                                            (lambda x: x.Fundamentals.OperationRatios.CurrentRatio.ThreeMonths, True, 1), 
                                            (lambda x: x.Fundamentals.OperationRatios.QuickRatio.ThreeMonths, True, 1)])
                                            
        safety_scores = self.Scores(added, [(lambda x: x.Fundamentals.OperationRatios.InterestCoverage.ThreeMonths, True, 1),
                                            (lambda x: x.Fundamentals.ValuationRatios.CashReturn, True, 1)])

        scores = {}
        # Assign a combined score to each stock 
        for symbol,value in value_scores.items():
            value_rank = value
            solvency_rank = solvency_scores[symbol]
            safety_rank = safety_scores[symbol]
            scores[symbol] = value_rank*self.value_weight + solvency_rank*self.solvency_weight + safety_rank*self.safety_weight
        
        # Sort the securities by their scores
        sorted_stock = sorted(scores.items(), key=lambda tup : tup[1], reverse=False)
        sorted_symbol = [tup[0] for tup in sorted_stock][:self.num_fine]
        
        # Sort the top stocks into the long_list
        self.longs = [security.Symbol for security in sorted_symbol]
        
        # Log longs symbols and their score
        algorithm.Log(", ".join([str(x.Symbol.Value) + ": " + str(scores[x]) for x in sorted_symbol]))


    def Scores(self, added, fundamentals):
        '''Assigns scores to each stock in added
        Args: 
            added: list of sceurities 
            fundamentals: list of 3-tuples (lambda function, bool, float)
        Returns:
            Dictionary with score for each security'''
        
        length = len(fundamentals)
        
        if length == 0:
            return {}
        
        # Initialize helper variables
        scores = {}
        sortedBy = []
        rank = [0 for _ in fundamentals]
        
        # Normalize weights
        weights = [tup[2] for tup in fundamentals]
        weights = [float(i)/sum(weights) for i in weights]
        
        # Create sorted list for each fundamental factor passed
        for tup in fundamentals:
            sortedBy.append(sorted(added, key=tup[0], reverse=tup[1]))
        
        # Create and save score for each symbol
        for index,symbol in enumerate(sortedBy[0]):
            
            # Save symbol's rank for each fundamental factor
            rank[0] = index
            for j in range(1, length):
                rank[j] = sortedBy[j].index(symbol)
            
            # Save symbol's total score
            score = 0
            for i in range(length):
                score += rank[i] * weights[i]
            scores[symbol] = score
            
        return scores