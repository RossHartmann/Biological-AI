using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.Contracts.Environment;
using GeneticFaraday.Contracts.Metrics;
using GeneticFaraday.Contracts.Organisms;
using GeneticFaraday.GEP.AbstractModels.Environment;
using GeneticFaraday.GEP.Contracts.Environment.CallableGenesProviders;
using GeneticFaraday.GEP.Contracts.Organisms.Genes;

namespace GeneticFaraday.GEP.Models.Environment
{
    public class GEPEnvironment : GEPEnvironmentBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="state"></param>
        /// <param name="metricsEvaluator"></param>
        /// <param name="endCriteriaEvaluator"></param>
        /// <param name="getCallableGenes">Gets the IGEPGenes that can be called by the given IGEPGene.</param>
        public GEPEnvironment(IEnvironmentIdentifier identifier, IEnvironmentState state, 
            IMetricsEvaluator metricsEvaluator, IEndCriteriaEvaluator endCriteriaEvaluator,
            IComparer<IOrganism> organismValueComparer,
            ICallableGenesProvider callableGenesProvider)
            : base(identifier, state, metricsEvaluator, endCriteriaEvaluator, callableGenesProvider: callableGenesProvider, organismValueComparer: organismValueComparer)
        {
        }
    }
}
