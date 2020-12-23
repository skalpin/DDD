using System;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Geo-Location
    /// </summary>
    public class GeoLocation
    {
        
        /// <summary>
        /// Latitude
        /// <para>-90 to 90 Degrees</para>
        /// </summary>
        [Range(-90.0, 90.0)]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// <para>-180 to 180 Degrees</para>
        /// </summary>
        [Range(-180.0, 180.0)]
        public double Longitude { get; set; }
        
        /// <summary>
        /// Elevation (meters)
        /// <para> -9999 to 9999 Meters</para>
        /// </summary>
        [Range(-9999,9999)]
        public double Elevation { get; set; }

        /// <summary>
        /// Confidence in Geolocation (a percentage)
        /// <para>0% to 100%</para>
        /// </summary>
        [Range(0, 100)]
        public decimal ScorePercent { get; set; }
    }
}
