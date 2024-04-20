﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProyectoDesarrollo.Models
{
    public class Warehouses
    {
        [Key]
        [JsonPropertyName("warehouse_id")]
        public int WAREHOUSE_ID { get; set; }
        [JsonPropertyName("warehouse_name")]
        public string? WAREHOUSE_NAME { get; set; }
        [JsonPropertyName("location_id")]
        public int? LOCATION_ID { get; set; }

    }
}
