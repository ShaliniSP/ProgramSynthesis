﻿using Microsoft.ProgramSynthesis;
using Microsoft.ProgramSynthesis.AST;
using Microsoft.ProgramSynthesis.Features;

namespace ProseTutorial
{
    public class RankingScore : Feature<double>
    {
        public RankingScore(Grammar grammar) : base(grammar, "Score")
        {
        }

        protected override double GetFeatureValueForVariable(VariableNode variable)
        {
            return 0;
        }

        [FeatureCalculator(nameof(Semantics.Plus))]
        public static double Plus(double v, double k)
        {
            return k/10;
        }

        [FeatureCalculator(nameof(Semantics.Minus))]
        public static double Minus(double v, double k)
        {
            return k/10;
        }

        [FeatureCalculator("k", Method = CalculationMethod.FromLiteral)]
        public static double K(int k)
        {
            return 0;
        }
    }
}