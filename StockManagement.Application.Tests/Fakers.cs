using Bogus;
using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Application.Tests
{
    public static class Fakers
    {
        public static Faker<Users> UserDetail => new Faker<Users>()
             .RandomRuleForPrimitiveTypes()
             .RuleFor(c => c.Id, f => f.Random.Guid())
             .RuleFor(c => c.FirstName, f => f.Person.FirstName)
             .RuleFor(c => c.LastName, f => f.Person.LastName)
             .RuleFor(c => c.Email, f => f.Person.Email)
             .RuleFor(c => c.IsActive, f => f.Random.Bool())
             ;
    }
    public static class PrimitiveTypesFakerExtensions
    {
        public static Faker<T> RandomRuleForPrimitiveTypes<T>(this Faker<T> faker) where T : class
        {
            return faker
                .RuleForType(typeof(Guid), f => Guid.NewGuid())
                .RuleForType(typeof(bool), f => f.Random.Bool())
                .RuleForType(typeof(DateTime), f => DateTime.Now);
        }
    }
}
