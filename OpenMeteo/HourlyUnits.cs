﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenMeteo
{
    public class HourlyUnits
    {
        public string? Time { get; set; }
        public string? Temperature_2m { get; set; }
        public string? Relativehumidity_2m { get; set; }
        public string? Dewpoint_2m { get; set; }
        public string? Apparent_temperature { get; set; }
        public string? Precipitation { get; set; }
        public string? Rain { get; set; }
        public string? Showers { get; set; }
        public string? Snowfall { get; set; }
        public string? Snow_depth { get; set; }
        public string? Freezinglevel_height { get; set; }
        public string? Weathercode { get; set; }
        public string? Pressure_msl { get; set; }
        public string? Surface_pressure { get; set; }
        public string? Cloudcover { get; set; }
        public string? Cloudcover_low { get; set; }
        public string? Cloudcover_mid { get; set; }
        public string? Cloudcover_high { get; set; }
        public string? Evapotranspiration { get; set; }
        public string? Et0_fao_evapotranspiration { get; set; }
        public string? Vapor_pressure_deficit { get; set; }
        public string? Windspeed_10m { get; set; }
        public string? Windspeed_80m { get; set; }
        public string? Windspeed_120m { get; set; }
        public string? Windspeed_180m { get; set; }
        public string? Winddirection_10m { get; set; }
        public string? Winddirection_80m { get; set; }
        public string? Winddirection_120m { get; set; }
        public string? Winddirection_180m { get; set; }
        public string? Windgusts_10m { get; set; }
        public string? Soil_temperature_0cm { get; set; }
        public string? Soil_temperature_6cm { get; set; }
        public string? Soil_temperature_18cm { get; set; }
        public string? Soil_temperature_54cm { get; set; }
        public string? Soil_moisture_0_1cm { get; set; }
        public string? Soil_moisture_1_3cm { get; set; }
        public string? Soil_moisture_3_9cm { get; set; }
        public string? Soil_moisture_9_27cm { get; set; }
        public string? Soil_moisture_27_81cm { get; set; }
        public string? Shortwave_radiation { get; set; }
        public string? Direct_radiation { get; set; }
        public string? Diffuse_radiation { get; set; }
        public string? Direct_normal_irradiance { get; set; }
        public string? Terrestrial_radiation { get; set; }
        public string? Shortwave_radiation_instant { get; set; }
        public string? Direct_radiation_instant { get; set; }
        public string? Diffuse_radiation_instant { get; set; }
        public string? Direct_normal_irradiance_instant { get; set; }
        public string? Terrestrial_radiation_instant { get; set; }

        // v0.0.74 - Pressure Levels
        public string? Temperature_1000hPa { get; set; }
        public string? Temperature_975hPa { get; set; }
        public string? Temperature_950hPa { get; set; }
        public string? Temperature_925hPa { get; set; }
        public string? Temperature_900hPa { get; set; }
        public string? Temperature_850hPa { get; set; }
        public string? Temperature_800hPa { get; set; }
        public string? Temperature_700hPa { get; set; }
        public string? Temperature_600hPa { get; set; }
        public string? Temperature_500hPa { get; set; }
        public string? Temperature_400hPa { get; set; }
        public string? Temperature_300hPa { get; set; }
        public string? Temperature_250hPa { get; set; }
        public string? Temperature_200hPa { get; set; }
        public string? Temperature_150hPa { get; set; }
        public string? Temperature_100hPa { get; set; }
        public string? Temperature_70hPa { get; set; }
        public string? Temperature_50hPa { get; set; }
        public string? Temperature_30hPa { get; set; }
        public string? Dewpoint_1000hPa { get; set; }
        public string? Dewpoint_975hPa { get; set; }
        public string? Dewpoint_950hPa { get; set; }
        public string? Dewpoint_925hPa { get; set; }
        public string? Dewpoint_900hPa { get; set; }
        public string? Dewpoint_850hPa { get; set; }
        public string? Dewpoint_800hPa { get; set; }
        public string? Dewpoint_700hPa { get; set; }
        public string? Dewpoint_600hPa { get; set; }
        public string? Dewpoint_500hPa { get; set; }
        public string? Dewpoint_400hPa { get; set; }
        public string? Dewpoint_300hPa { get; set; }
        public string? Dewpoint_250hPa { get; set; }
        public string? Dewpoint_200hPa { get; set; }
        public string? Dewpoint_150hPa { get; set; }
        public string? Dewpoint_100hPa { get; set; }
        public string? Dewpoint_70hPa { get; set; }
        public string? Dewpoint_50hPa { get; set; }
        public string? Dewpoint_30hPa { get; set; }
        public string? Relativehumidity_1000hPa { get; set; }
        public string? Relativehumidity_975hPa { get; set; }
        public string? Relativehumidity_950hPa { get; set; }
        public string? Relativehumidity_925hPa { get; set; }
        public string? Relativehumidity_900hPa { get; set; }
        public string? Relativehumidity_850hPa { get; set; }
        public string? Relativehumidity_800hPa { get; set; }
        public string? Relativehumidity_700hPa { get; set; }
        public string? Relativehumidity_600hPa { get; set; }
        public string? Relativehumidity_500hPa { get; set; }
        public string? Relativehumidity_400hPa { get; set; }
        public string? Relativehumidity_300hPa { get; set; }
        public string? Relativehumidity_250hPa { get; set; }
        public string? Relativehumidity_200hPa { get; set; }
        public string? Relativehumidity_150hPa { get; set; }
        public string? Relativehumidity_100hPa { get; set; }
        public string? Relativehumidity_70hPa { get; set; }
        public string? Relativehumidity_50hPa { get; set; }
        public string? Relativehumidity_30hPa { get; set; }
        public string? Cloudcover_1000hPa { get; set; }
        public string? Cloudcover_975hPa { get; set; }
        public string? Cloudcover_950hPa { get; set; }
        public string? Cloudcover_925hPa { get; set; }
        public string? Cloudcover_900hPa { get; set; }
        public string? Cloudcover_850hPa { get; set; }
        public string? Cloudcover_800hPa { get; set; }
        public string? Cloudcover_700hPa { get; set; }
        public string? Cloudcover_600hPa { get; set; }
        public string? Cloudcover_500hPa { get; set; }
        public string? Cloudcover_400hPa { get; set; }
        public string? Cloudcover_300hPa { get; set; }
        public string? Cloudcover_250hPa { get; set; }
        public string? Cloudcover_200hPa { get; set; }
        public string? Cloudcover_150hPa { get; set; }
        public string? Cloudcover_100hPa { get; set; }
        public string? Cloudcover_70hPa { get; set; }
        public string? Cloudcover_50hPa { get; set; }
        public string? Cloudcover_30hPa { get; set; }
        public string? Windspeed_1000hPa { get; set; }
        public string? Windspeed_975hPa { get; set; }
        public string? Windspeed_950hPa { get; set; }
        public string? Windspeed_925hPa { get; set; }
        public string? Windspeed_900hPa { get; set; }
        public string? Windspeed_850hPa { get; set; }
        public string? Windspeed_800hPa { get; set; }
        public string? Windspeed_700hPa { get; set; }
        public string? Windspeed_600hPa { get; set; }
        public string? Windspeed_500hPa { get; set; }
        public string? Windspeed_400hPa { get; set; }
        public string? Windspeed_300hPa { get; set; }
        public string? Windspeed_250hPa { get; set; }
        public string? Windspeed_200hPa { get; set; }
        public string? Windspeed_150hPa { get; set; }
        public string? Windspeed_100hPa { get; set; }
        public string? Windspeed_70hPa { get; set; }
        public string? Windspeed_50hPa { get; set; }
        public string? Windspeed_30hPa { get; set; }
        public string? Winddirection_1000hPa { get; set; }
        public string? Winddirection_975hPa { get; set; }
        public string? Winddirection_950hPa { get; set; }
        public string? Winddirection_925hPa { get; set; }
        public string? Winddirection_900hPa { get; set; }
        public string? Winddirection_850hPa { get; set; }
        public string? Winddirection_800hPa { get; set; }
        public string? Winddirection_700hPa { get; set; }
        public string? Winddirection_600hPa { get; set; }
        public string? Winddirection_500hPa { get; set; }
        public string? Winddirection_400hPa { get; set; }
        public string? Winddirection_300hPa { get; set; }
        public string? Winddirection_250hPa { get; set; }
        public string? Winddirection_200hPa { get; set; }
        public string? Winddirection_150hPa { get; set; }
        public string? Winddirection_100hPa { get; set; }
        public string? Winddirection_70hPa { get; set; }
        public string? Winddirection_50hPa { get; set; }
        public string? Winddirection_30hPa { get; set; }
        public string? Geopotential_height_1000hPa { get; set; }
        public string? Geopotential_height_975hPa { get; set; }
        public string? Geopotential_height_950hPa { get; set; }
        public string? Geopotential_height_925hPa { get; set; }
        public string? Geopotential_height_900hPa { get; set; }
        public string? Geopotential_height_850hPa { get; set; }
        public string? Geopotential_height_800hPa { get; set; }
        public string? Geopotential_height_700hPa { get; set; }
        public string? Geopotential_height_600hPa { get; set; }
        public string? Geopotential_height_500hPa { get; set; }
        public string? Geopotential_height_400hPa { get; set; }
        public string? Geopotential_height_300hPa { get; set; }
        public string? Geopotential_height_250hPa { get; set; }
        public string? Geopotential_height_200hPa { get; set; }
        public string? Geopotential_height_150hPa { get; set; }
        public string? Geopotential_height_100hPa { get; set; }
        public string? Geopotential_height_70hPa { get; set; }
        public string? Geopotential_height_50hPa { get; set; }
        public string? Geopotential_height_30hPa { get; set; }
    }
}
