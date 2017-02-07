﻿using MassSpectrometry;
using MzLibUtil;

namespace IO.Thermo
{
    public class ThermoScanWithPrecursor : MsDataScanWithPrecursor<ThermoSpectrum, ThermoMzPeak>, IThermoScan
    {
        #region Public Constructors

        public ThermoScanWithPrecursor(int ScanNumber, ThermoSpectrum massSpectrum, string id, int MsnOrder, bool isCentroid, Polarity Polarity, double RetentionTime, MzRange MzRange, string ScanFilter, MZAnalyzerType MzAnalyzer, double InjectionTime, double TotalIonCurrent, string precursorID, double selectedIonGuessMZ, int? selectedIonGuessChargeStateGuess, double selectedIonGuessIntensity, double isolationMZ, double isolationWidth, DissociationType dissociationType, int oneBasedPrecursorScanNumber, double selectedIonGuessMonoisotopicIntensity, double selectedIonGuessMonoisotopicMZ)
            : base(ScanNumber, id, MsnOrder, isCentroid, Polarity, RetentionTime, MzRange, ScanFilter, MzAnalyzer, InjectionTime, TotalIonCurrent, precursorID, selectedIonGuessMZ, selectedIonGuessChargeStateGuess, selectedIonGuessIntensity, isolationMZ, isolationWidth, dissociationType, oneBasedPrecursorScanNumber, selectedIonGuessMonoisotopicIntensity, selectedIonGuessMonoisotopicMZ)
        {
            this.MassSpectrum = massSpectrum;
        }

        #endregion Public Constructors
    }
}