﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Heat Transfer Coefficient or Thermal conductivity - indicates a materials ability to conduct heat.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ThermalResistance
#else
    public partial struct ThermalResistance : IComparable, IComparable<ThermalResistance>
#endif
    {
        /// <summary>
        ///     Base unit of ThermalResistance.
        /// </summary>
        private readonly double _squareMeterKelvinsPerKilowatt;

		// Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public ThermalResistance() : this(0)
        {
        }
#endif

        public ThermalResistance(double squaremeterkelvinsperkilowatt)
        {
            _squareMeterKelvinsPerKilowatt = Convert.ToDouble(squaremeterkelvinsperkilowatt);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        ThermalResistance(long squaremeterkelvinsperkilowatt)
        {
            _squareMeterKelvinsPerKilowatt = Convert.ToDouble(squaremeterkelvinsperkilowatt);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        ThermalResistance(decimal squaremeterkelvinsperkilowatt)
        {
            _squareMeterKelvinsPerKilowatt = Convert.ToDouble(squaremeterkelvinsperkilowatt);
        }

        #region Properties

        public static ThermalResistanceUnit BaseUnit
        {
            get { return ThermalResistanceUnit.SquareMeterKelvinPerKilowatt; }
        }

        /// <summary>
        ///     Get ThermalResistance in HourSquareFeetDegreesFahrenheitPerBtu.
        /// </summary>
        public double HourSquareFeetDegreesFahrenheitPerBtu
        {
            get { return _squareMeterKelvinsPerKilowatt/176.1121482159839; }
        }

        /// <summary>
        ///     Get ThermalResistance in SquareCentimeterHourDegreesCelsiusPerKilocalorie.
        /// </summary>
        public double SquareCentimeterHourDegreesCelsiusPerKilocalorie
        {
            get { return _squareMeterKelvinsPerKilowatt/0.0859779507590433; }
        }

        /// <summary>
        ///     Get ThermalResistance in SquareCentimeterKelvinsPerWatt.
        /// </summary>
        public double SquareCentimeterKelvinsPerWatt
        {
            get { return _squareMeterKelvinsPerKilowatt/0.0999964777570357; }
        }

        /// <summary>
        ///     Get ThermalResistance in SquareMeterDegreesCelsiusPerWatt.
        /// </summary>
        public double SquareMeterDegreesCelsiusPerWatt
        {
            get { return _squareMeterKelvinsPerKilowatt/1000.088056074108; }
        }

        /// <summary>
        ///     Get ThermalResistance in SquareMeterKelvinsPerKilowatt.
        /// </summary>
        public double SquareMeterKelvinsPerKilowatt
        {
            get { return _squareMeterKelvinsPerKilowatt; }
        }

        #endregion

        #region Static

        public static ThermalResistance Zero
        {
            get { return new ThermalResistance(); }
        }

        /// <summary>
        ///     Get ThermalResistance from HourSquareFeetDegreesFahrenheitPerBtu.
        /// </summary>
        public static ThermalResistance FromHourSquareFeetDegreesFahrenheitPerBtu(double hoursquarefeetdegreesfahrenheitperbtu)
        {
            return new ThermalResistance(hoursquarefeetdegreesfahrenheitperbtu*176.1121482159839);
        }

        /// <summary>
        ///     Get ThermalResistance from SquareCentimeterHourDegreesCelsiusPerKilocalorie.
        /// </summary>
        public static ThermalResistance FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(double squarecentimeterhourdegreescelsiusperkilocalorie)
        {
            return new ThermalResistance(squarecentimeterhourdegreescelsiusperkilocalorie*0.0859779507590433);
        }

        /// <summary>
        ///     Get ThermalResistance from SquareCentimeterKelvinsPerWatt.
        /// </summary>
        public static ThermalResistance FromSquareCentimeterKelvinsPerWatt(double squarecentimeterkelvinsperwatt)
        {
            return new ThermalResistance(squarecentimeterkelvinsperwatt*0.0999964777570357);
        }

        /// <summary>
        ///     Get ThermalResistance from SquareMeterDegreesCelsiusPerWatt.
        /// </summary>
        public static ThermalResistance FromSquareMeterDegreesCelsiusPerWatt(double squaremeterdegreescelsiusperwatt)
        {
            return new ThermalResistance(squaremeterdegreescelsiusperwatt*1000.088056074108);
        }

        /// <summary>
        ///     Get ThermalResistance from SquareMeterKelvinsPerKilowatt.
        /// </summary>
        public static ThermalResistance FromSquareMeterKelvinsPerKilowatt(double squaremeterkelvinsperkilowatt)
        {
            return new ThermalResistance(squaremeterkelvinsperkilowatt);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ThermalResistance from nullable HourSquareFeetDegreesFahrenheitPerBtu.
        /// </summary>
        public static ThermalResistance? FromHourSquareFeetDegreesFahrenheitPerBtu(double? hoursquarefeetdegreesfahrenheitperbtu)
        {
            if (hoursquarefeetdegreesfahrenheitperbtu.HasValue)
            {
                return FromHourSquareFeetDegreesFahrenheitPerBtu(hoursquarefeetdegreesfahrenheitperbtu.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ThermalResistance from nullable SquareCentimeterHourDegreesCelsiusPerKilocalorie.
        /// </summary>
        public static ThermalResistance? FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(double? squarecentimeterhourdegreescelsiusperkilocalorie)
        {
            if (squarecentimeterhourdegreescelsiusperkilocalorie.HasValue)
            {
                return FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(squarecentimeterhourdegreescelsiusperkilocalorie.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ThermalResistance from nullable SquareCentimeterKelvinsPerWatt.
        /// </summary>
        public static ThermalResistance? FromSquareCentimeterKelvinsPerWatt(double? squarecentimeterkelvinsperwatt)
        {
            if (squarecentimeterkelvinsperwatt.HasValue)
            {
                return FromSquareCentimeterKelvinsPerWatt(squarecentimeterkelvinsperwatt.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ThermalResistance from nullable SquareMeterDegreesCelsiusPerWatt.
        /// </summary>
        public static ThermalResistance? FromSquareMeterDegreesCelsiusPerWatt(double? squaremeterdegreescelsiusperwatt)
        {
            if (squaremeterdegreescelsiusperwatt.HasValue)
            {
                return FromSquareMeterDegreesCelsiusPerWatt(squaremeterdegreescelsiusperwatt.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ThermalResistance from nullable SquareMeterKelvinsPerKilowatt.
        /// </summary>
        public static ThermalResistance? FromSquareMeterKelvinsPerKilowatt(double? squaremeterkelvinsperkilowatt)
        {
            if (squaremeterkelvinsperkilowatt.HasValue)
            {
                return FromSquareMeterKelvinsPerKilowatt(squaremeterkelvinsperkilowatt.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ThermalResistanceUnit" /> to <see cref="ThermalResistance" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ThermalResistance unit value.</returns>
        public static ThermalResistance From(double val, ThermalResistanceUnit fromUnit)
        {
            switch (fromUnit)
            {
                case ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu:
                    return FromHourSquareFeetDegreesFahrenheitPerBtu(val);
                case ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie:
                    return FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(val);
                case ThermalResistanceUnit.SquareCentimeterKelvinPerWatt:
                    return FromSquareCentimeterKelvinsPerWatt(val);
                case ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt:
                    return FromSquareMeterDegreesCelsiusPerWatt(val);
                case ThermalResistanceUnit.SquareMeterKelvinPerKilowatt:
                    return FromSquareMeterKelvinsPerKilowatt(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ThermalResistanceUnit" /> to <see cref="ThermalResistance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ThermalResistance unit value.</returns>
        public static ThermalResistance? From(double? value, ThermalResistanceUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu:
                    return FromHourSquareFeetDegreesFahrenheitPerBtu(value.Value);
                case ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie:
                    return FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(value.Value);
                case ThermalResistanceUnit.SquareCentimeterKelvinPerWatt:
                    return FromSquareCentimeterKelvinsPerWatt(value.Value);
                case ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt:
                    return FromSquareMeterDegreesCelsiusPerWatt(value.Value);
                case ThermalResistanceUnit.SquareMeterKelvinPerKilowatt:
                    return FromSquareMeterKelvinsPerKilowatt(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ThermalResistanceUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ThermalResistanceUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static ThermalResistance operator -(ThermalResistance right)
        {
            return new ThermalResistance(-right._squareMeterKelvinsPerKilowatt);
        }

        public static ThermalResistance operator +(ThermalResistance left, ThermalResistance right)
        {
            return new ThermalResistance(left._squareMeterKelvinsPerKilowatt + right._squareMeterKelvinsPerKilowatt);
        }

        public static ThermalResistance operator -(ThermalResistance left, ThermalResistance right)
        {
            return new ThermalResistance(left._squareMeterKelvinsPerKilowatt - right._squareMeterKelvinsPerKilowatt);
        }

        public static ThermalResistance operator *(double left, ThermalResistance right)
        {
            return new ThermalResistance(left*right._squareMeterKelvinsPerKilowatt);
        }

        public static ThermalResistance operator *(ThermalResistance left, double right)
        {
            return new ThermalResistance(left._squareMeterKelvinsPerKilowatt*(double)right);
        }

        public static ThermalResistance operator /(ThermalResistance left, double right)
        {
            return new ThermalResistance(left._squareMeterKelvinsPerKilowatt/(double)right);
        }

        public static double operator /(ThermalResistance left, ThermalResistance right)
        {
            return Convert.ToDouble(left._squareMeterKelvinsPerKilowatt/right._squareMeterKelvinsPerKilowatt);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ThermalResistance)) throw new ArgumentException("Expected type ThermalResistance.", "obj");
            return CompareTo((ThermalResistance) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ThermalResistance other)
        {
            return _squareMeterKelvinsPerKilowatt.CompareTo(other._squareMeterKelvinsPerKilowatt);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(ThermalResistance left, ThermalResistance right)
        {
            return left._squareMeterKelvinsPerKilowatt <= right._squareMeterKelvinsPerKilowatt;
        }

        public static bool operator >=(ThermalResistance left, ThermalResistance right)
        {
            return left._squareMeterKelvinsPerKilowatt >= right._squareMeterKelvinsPerKilowatt;
        }

        public static bool operator <(ThermalResistance left, ThermalResistance right)
        {
            return left._squareMeterKelvinsPerKilowatt < right._squareMeterKelvinsPerKilowatt;
        }

        public static bool operator >(ThermalResistance left, ThermalResistance right)
        {
            return left._squareMeterKelvinsPerKilowatt > right._squareMeterKelvinsPerKilowatt;
        }

        public static bool operator ==(ThermalResistance left, ThermalResistance right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._squareMeterKelvinsPerKilowatt == right._squareMeterKelvinsPerKilowatt;
        }

        public static bool operator !=(ThermalResistance left, ThermalResistance right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._squareMeterKelvinsPerKilowatt != right._squareMeterKelvinsPerKilowatt;
        }
#endif

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _squareMeterKelvinsPerKilowatt.Equals(((ThermalResistance) obj)._squareMeterKelvinsPerKilowatt);
        }

        public override int GetHashCode()
        {
            return _squareMeterKelvinsPerKilowatt.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(ThermalResistanceUnit unit)
        {
            switch (unit)
            {
                case ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu:
                    return HourSquareFeetDegreesFahrenheitPerBtu;
                case ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie:
                    return SquareCentimeterHourDegreesCelsiusPerKilocalorie;
                case ThermalResistanceUnit.SquareCentimeterKelvinPerWatt:
                    return SquareCentimeterKelvinsPerWatt;
                case ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt:
                    return SquareMeterDegreesCelsiusPerWatt;
                case ThermalResistanceUnit.SquareMeterKelvinPerKilowatt:
                    return SquareMeterKelvinsPerKilowatt;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ThermalResistance Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ThermalResistance Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return UnitParser.ParseUnit<ThermalResistanceUnit, ThermalResistance>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ThermalResistanceUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromSquareMeterKelvinsPerKilowatt(x.SquareMeterKelvinsPerKilowatt + y.SquareMeterKelvinsPerKilowatt));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ThermalResistance result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ThermalResistance result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(ThermalResistance);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ThermalResistanceUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ThermalResistanceUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static ThermalResistanceUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<ThermalResistanceUnit>(str.Trim());

            if (unit == ThermalResistanceUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ThermalResistanceUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is SquareMeterKelvinPerKilowatt
        /// </summary>
        public static ThermalResistanceUnit ToStringDefaultUnit { get; set; } = ThermalResistanceUnit.SquareMeterKelvinPerKilowatt;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ThermalResistanceUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(ThermalResistanceUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ThermalResistanceUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ThermalResistanceUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of ThermalResistance
        /// </summary>
        public static ThermalResistance MaxValue
        {
            get
            {
                return new ThermalResistance(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of ThermalResistance
        /// </summary>
        public static ThermalResistance MinValue
        {
            get
            {
                return new ThermalResistance(double.MinValue);
            }
        }
    }
}
