using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;
namespace Domain.Models;

public class FinancialRecord
{
    public int Id { get; set; }
    public FinancialRecordType Type { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = null!;
    public DateTime? RecordDate { get; set; }
    public DateTime? CreatedAt { get; set; }

}