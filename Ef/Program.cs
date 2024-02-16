
using Ef.Data;
using Ef.Extensions;
using Ef.Models;

DataAccess dataAccess = new(Configurations.Options());

People people = new()
{
   Name = "Maria Aparecida Dias Cintra",
   CreatedAt = DateTime.Now.AddDays(-1)
};
dataAccess.Add(people);
dataAccess.SaveChanges();
dataAccess.Peoples.ToList()
   .ForEach(c =>
   {
      Console.WriteLine("{0:0000} {1} {2}", c.Id, c.Name.SpaceWith(100, ' '), c.CreatedAt);
   });

