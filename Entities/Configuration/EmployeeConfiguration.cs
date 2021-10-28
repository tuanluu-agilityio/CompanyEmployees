using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = new Guid("8b5285bf-03ec-42b5-a95a-a70ccd2a751f"),
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software developer",
                    CompanyId = new Guid("0ccc6a11-8598-4c5f-b07a-fba2b00b1877"),
                },
                new Employee
                {
                    Id = new Guid("6c471e02-c381-4589-9316-799d59337f1f"),
                    Name = "Jana McLeaf",
                    Age = 30,
                    Position = "Software developer",
                    CompanyId = new Guid("0ccc6a11-8598-4c5f-b07a-fba2b00b1877"),
                },
                new Employee
                {
                    Id = new Guid("6d7c5c8f-bda9-4ecb-bff7-686b5e54c7f6"),
                    Name = "Kane Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new Guid("c04a51cc-6a8d-426c-85e3-3a86bd35b48e"),
                }
            );
        }
    }
}
