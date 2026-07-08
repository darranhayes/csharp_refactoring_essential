namespace Duplication;

using System;
using System.Collections.Generic;

public class WeatherReport
{
    public void FormatDailyReport(List<Forecast> forecasts, List<string> output)
    {
        foreach (Forecast forecast in forecasts)
        {
            string temperature = forecast.GetTemperature().ToString("0.0");
            string timePeriod = "";

            if (forecast.IsMorning())
            {
                timePeriod = "Morning: ";
            }

            if (forecast.IsAfternoon())
            {
                timePeriod = "Afternoon: ";
            }

            if (forecast.IsEvening())
            {
                timePeriod = "Evening: ";
            }

            if (forecast.IsNight())
            {
                timePeriod = "Night: ";
            }

            string line = FormatForecastReportLine(timePeriod, temperature, forecast);
            output.Add(line);

        }
    }

    private static string FormatForecastReportLine(string timePeriod, string temperature, Forecast forecast)
    {
        return timePeriod + temperature + "°C, "
               + forecast.GetCondition() + ", wind " + forecast.GetWindSpeed() + "km/h";
    }
}

public class Forecast
{
    private readonly string period; // "morning", "afternoon", "evening", "night"
    private readonly double temperature;
    private readonly string condition;
    private readonly int windSpeed;

    public Forecast(string period, double temperature, string condition, int windSpeed)
    {
        this.period = period;
        this.temperature = temperature;
        this.condition = condition;
        this.windSpeed = windSpeed;
    }

    public double GetTemperature()
    {
        return temperature;
    }

    public string GetCondition()
    {
        return condition;
    }

    public int GetWindSpeed()
    {
        return windSpeed;
    }

    public bool IsMorning()
    {
        return period == "morning";
    }

    public bool IsAfternoon()
    {
        return period == "afternoon";
    }

    public bool IsEvening()
    {
        return period == "evening";
    }

    public bool IsNight()
    {
        return period == "night";
    }
}