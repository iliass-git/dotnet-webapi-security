
using Microsoft.AspNetCore.Mvc;
using DemoWebAPI.Models;
using System.Text;

public class DummyController : ControllerBase
{
    [Route("api/dummies")]
    [HttpGet]
    public string GetDummies()
    {
        var content = new List<DummyModel>{
            new DummyModel { Id = 1, Name = "Dummy 1", Description = "Description 1" },
            new DummyModel { Id = 2, Name = "Dummy 2", Description = "Description 2" },
            new DummyModel { Id = 3, Name = "Dummy 3", Description = "Description 3" },
            new DummyModel { Id = 4, Name = "Dummy 4", Description = "Description 4" },
            new DummyModel { Id = 5, Name = "Dummy 5", Description = "Description 5" }
        };
        var httpcontent = new StringContent(
            System.Text.Json.JsonSerializer.Serialize(content),
            Encoding.UTF8,
            "application/json"
        );
        return	httpcontent.ReadAsStringAsync().Result;
    }
}