using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.GEP.Contracts.Organisms.OrganismBehavior
{
    /// <summary>
    /// Stores the execution data for an IGene that will be used during the 
    /// execution of an IOrganism.
    /// </summary>
    public interface IGeneExecutionData
    {
        /// <summary>
        /// Used during the execution of an IGene.
        /// 
        /// Any time the IGene is started or an IAminoAcid within the IGene is executed, this 
        /// value will be incremented by 1.
        /// 
        /// When the IGene is finished executing or an IAminoAcid within the IGene is finished 
        /// executing, this value will be decremented by 1.
        /// 
        /// In this way, the value will be higher if an IAllele is called within itself (i.e. recursively)
        /// or too many IAminoAcids are executed recursively.
        /// 
        /// This value indicates the current level of recursion during the execution of the owning IGene.
        /// </summary>
        int RecursionLevel { get; set; }
    }
}
