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
            string formattedTimePeriod = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(forecast.GetPeriod());

            string line = formattedTimePeriod + ": " + temperature + "°C, "
                          + forecast.GetCondition() + ", wind " + forecast.GetWindSpeed() + "km/h";

            output.Add(line);

        }
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

    public string GetPeriod()
    {
        return period;
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