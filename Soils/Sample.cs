﻿
namespace APSIM.Shared.Soils
{
    using System.Xml.Serialization;

    /// <summary>
    /// Represents a soil sample.
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the sample date.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the thickness.
        /// </summary>
        public double[] Thickness { get; set; }
        /// <summary>
        /// Gets or sets the NO3.
        /// </summary>
        public double[] NO3 { get; set; }
        /// <summary>
        /// Gets or sets the NH4.
        /// </summary>
        public double[] NH4 { get; set; }
        /// <summary>
        /// Gets or sets the soil water
        /// </summary>
        public double[] SW { get; set; }
        /// <summary>
        /// Gets or sets the organic carbon
        /// </summary>
        public double[] OC { get; set; }
        /// <summary>
        /// Gets or sets the EC.
        /// </summary>
        [Units("1:5 dS/m")]
        public double[] EC { get; set; }
        /// <summary>
        /// Gets or sets the CL.
        /// </summary>
        [Units("mg/kg")]
        public double[] CL { get; set; }
        /// <summary>
        /// Gets or sets the ESP.
        /// </summary>
        [Units("%")]
        public double[] ESP { get; set; }
        /// <summary>
        /// Gets or sets the PH.
        /// </summary>
        public double[] PH { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sample"/> class.
        /// </summary>
        public Sample() {Name = "Sample"; }

        // Support for NO3 units.
        /// <summary>
        /// Valid units for NO3
        /// </summary>
        public enum NUnitsEnum 
        {
            /// <summary>
            /// PPM units
            /// </summary>
            ppm,

            /// <summary>
            /// kgha units.
            /// </summary>
            kgha 
        }
        /// <summary>
        /// Gets or sets the NO3 units.
        /// </summary>
        public NUnitsEnum NO3Units { get; set; }
                 
        // Support for NH4 units.
        /// <summary>
        /// Gets or sets the NH4 units.
        /// </summary>
        public NUnitsEnum NH4Units { get; set; }
         
        // Support for SW units.
        /// <summary>
        /// Valid units for soil water
        /// </summary>
        public enum SWUnitsEnum 
        {
            /// <summary>
            /// volumetric (mm/mm)
            /// </summary>
            Volumetric,

            /// <summary>
            /// gravimetric (mm/mm)
            /// </summary>
            Gravimetric,

            /// <summary>
            /// Total water (mm)
            /// </summary>
            mm 
        }
        /// <summary>
        /// Gets or sets the SW units.
        /// </summary>
        public SWUnitsEnum SWUnits { get; set; }

        // Support for OC units.
        /// <summary>
        /// Valid units for organic carbon
        /// </summary>
        public enum OCSampleUnitsEnum 
        {
            /// <summary>
            /// total (%)
            /// </summary>
            Total,

            /// <summary>
            /// walkley black (%)
            /// </summary>
            WalkleyBlack 
        }

        /// <summary>
        /// Gets or sets the OC units.
        /// </summary>
        public OCSampleUnitsEnum OCUnits { get; set; }

        /// <summary>
        /// Valid units for PH.
        /// </summary>
        public enum PHSampleUnitsEnum 
        {
            /// <summary>
            /// water
            /// </summary>
            Water,

            /// <summary>
            /// CaCL2
            /// </summary>
            CaCl2 
        }

        /// <summary>
        /// Gets or sets the PH units.
        /// </summary>
        public PHSampleUnitsEnum PHUnits { get; set; }
    }
}
