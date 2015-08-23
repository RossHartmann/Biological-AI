using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Registries
{
    public enum RegistryType
    {
        /// <summary>
        /// Indicates that the IRegistry is provided to the IGEPEnvironment
        /// with values already populated.
        /// </summary>
        Input,
        /// <summary>
        /// Indicates that the IRegistry is shared among all IGEPChromosomes
        /// and all IGEPGenes in the IGEPOrganism.
        /// 
        /// This IRegistry stores the intermediate calculations of an IGEPOrganism run.
        /// It is the "scratch pad."
        /// </summary>
        Global,
        /// <summary>
        /// Indicates that the IRegistry is shared among all IGEPChromosomes
        /// and all IGEPGenes in the IGEPOrganism.
        /// 
        /// This IRegistry stores the "Results" of an IGEPOrganism run.
        /// </summary>
        Result,
        /// <summary>
        /// Indicates that the IRegistry is only available to the IGEPChromosome
        /// that is running and all of its children IGEPGenes.
        /// </summary>
        LocalGlobal,
        /// <summary>
        /// Indicates that the IRegistry is only available to the IGEPGene that is
        /// running.
        /// </summary>
        Local,
    }
}
