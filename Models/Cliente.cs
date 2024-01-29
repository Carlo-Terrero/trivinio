using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace PruebaTrivinio.Models;

public class Cliente
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Surnames {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}
    public string Country {get; set;}
    [DataType(DataType.Date)]
    public DateTime Birthdate {get; set;}
}