using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticFaraday.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Codons;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.DNAs.AminoAcids.Arguments;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;

namespace GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes.DNAs.AminoAcids
{
    public abstract class GEPAminoAcidBase : AminoAcidBase, IGEPAminoAcid
    {
        /// <summary>
        /// The IArguments of the IGEPAminoAcid.
        /// </summary>
        public List<IArgument> Arguments { get; protected set; }

        /// <summary>
        /// The IGEPCodon that encoded for this IGEPAminoAcid.
        /// </summary>
        new public IGEPCodon Codon { get; private set; }

        /// <summary>
        /// If true, The Parameterless IFunction in the ICodon will be the IFunction
        /// that is executed.
        /// 
        /// If false, the Primary IFunction in the ICodon will be used.
        /// </summary>
        public bool UseParameterlessFunction { get; private set; }

        /// <summary>
        /// The identifier of the IFunction that this IAminoAcid represents.
        /// </summary>
        public IFunctionIdentifier Function 
        { 
            get
            {
                return this.UseParameterlessFunction
                           ? this.Codon.Functions.ParameterlessFunction
                           : this.Codon.Functions.PrimaryFunction;
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codon">The IGEPCodon that encoded for this IGEPAminoAcid.</param>
        /// <param name="useParameterlessFunction">If true, The Parameterless IFunction in the ICodon will be the IFunction
        /// that is executed.
        /// 
        /// If false, the Primary IFunction in the ICodon will be used.</param>
        protected GEPAminoAcidBase(IGEPCodon codon, bool useParameterlessFunction) 
            : base(codon)
        {
            this.Codon = codon;
            this.UseParameterlessFunction = useParameterlessFunction;
            this.Arguments = new List<IArgument>();
        }

        public IEnumerator<IArgument> GetEnumerator()
        {
            return this.Arguments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(IArgument item)
        {
            this.Arguments.Add(item: item);
        }

        public void Clear()
        {
            this.Arguments.Clear();
        }

        public bool Contains(IArgument item)
        {
            return this.Arguments.Contains(item: item);
        }

        public void CopyTo(IArgument[] array, int arrayIndex)
        {
            this.Arguments.CopyTo(array: array, arrayIndex: arrayIndex);
        }

        public bool Remove(IArgument item)
        {
            return this.Arguments.Remove(item: item);
        }

        public int Count { get { return this.Arguments.Count; } }

        public bool IsReadOnly { get { return false; } }

        public int IndexOf(IArgument item)
        {
            return this.Arguments.IndexOf(item: item);
        }

        public void Insert(int index, IArgument item)
        {
            this.Arguments.Insert(index: index, item: item);
        }

        public void RemoveAt(int index)
        {
            this.Arguments.RemoveAt(index: index);
        }

        public IArgument this[int index]
        {
            get { return this.Arguments[index]; }
            set { this.Arguments[index] = value; }
        }

        
    }
}
