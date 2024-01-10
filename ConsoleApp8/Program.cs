using NUnit.Framework;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

[TestFixture]
class CalculatorTests
{
    [Test]
    public void Calculate_ValidArray_ReturnsCorrectResult()
    {
        double[] testData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var result = Calculator.Calculate(testData);

        Assert.AreEqual(waiting_result, result);
    }

    [Test]
    public void SaveData_ValidInput_SavesData()
    {
        string saveInput = "1"; // Пример ввода для сохранения в формате JSON
        double[] testData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример тестовых данных

        Calculator.SaveData(saveInput, testData);

        
    }

    [Test]
    public void ReadDataFromJson_ValidFile_ReturnsArray()
    {
        string filePath = "path_to_valid_json_file.json";

        var result = Calculator.ReadDataFromJson(filePath);

        Assert.IsNotNull(result);
        Assert.AreEqual(10, result.Length); // Предположим, что длина массива должна быть 10
    }

    [Test]
    public void ReadDataFromXml_ValidFile_ReturnsArray()
    {
        string filePath = "path_to_valid_xml_file.xml";

        var result = Calculator.ReadDataFromXml(filePath);

        Assert.IsNotNull(result);
        Assert.AreEqual(10, result.Length); // Предположим, что длина массива должна быть 10
    }

    [Test]
    public void Main_ValidInput_DoesNotThrowException()
    {
        
        Assert.DoesNotThrow(() => Calculator.Main());
    }

}
