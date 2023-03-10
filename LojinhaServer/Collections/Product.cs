using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace LojinhaServer.Collections

[Table("products")]
[BsonIgnoreExtraElements]
public class product
{
    [BsonId]
    [BsonRepresentation{}




