// A smart city has 30 street lights numbered 1 to 30. The power consumption (in watts) for each light is calculated using the formula:
// Power = 80 + (Light Number × 5)
// For each street light:
// * If power consumption is greater than 180 W, display "Maintenance Required".
// * Else if power consumption is between 140 W and 180 W, display "Normal Operation".
// * Otherwise, display "Energy Efficient".
// Also calculate and display:
// * Total power consumed by all street lights
// * Average power consumption
// * Number of lights in each category

using System;

class PowerAnalyzer{
    public void Run(){
        //Om Prashant Gond IT SSGMCE Task 2 Jul7
        int powerConsumption, totalPowerConsumption, countLightsMaintainence, countLightsNormalOperations, countefficentEnergy;
        powerConsumption = totalPowerConsumption = countLightsMaintainence = countLightsNormalOperations = countefficentEnergy = 0;
        float averagePowerConsumption = 0f;

        for(int lightNumber= 1; lightNumber <= 30; lightNumber++){
            powerConsumption = 80 + (lightNumber * 5);
            if(powerConsumption > 180){
                countLightsMaintainence++;
                Console.WriteLine($"Maintainence required for light number {lightNumber}");
            }
            else if(powerConsumption > 140 && powerConsumption < 180){
                countLightsNormalOperations++;
                Console.WriteLine($"Light number {lightNumber} is under normal operation");
            }
            else{
                countefficentEnergy++;
                Console.WriteLine($"Light number {lightNumber} is energy efficient");
            }
            totalPowerConsumption += powerConsumption;
        }
        averagePowerConsumption = (float)totalPowerConsumption / 30;
        Console.WriteLine($"Total power consumption : {totalPowerConsumption}");
        Console.WriteLine($"Average power consumption : {averagePowerConsumption}");
        Console.WriteLine($"Total bulbs needed maintainence : {countLightsMaintainence} toatal under normal working : {countLightsNormalOperations} and total under efficient consumption {countefficentEnergy}");


    }
}

