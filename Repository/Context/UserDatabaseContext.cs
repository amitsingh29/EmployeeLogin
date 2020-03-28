//-----------------------------------------------------------------------
// <copyright file="Employee.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Repository.Context
{
    using Microsoft.EntityFrameworkCore;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UserDatabaseContext class 
    /// </summary>
    public class UserDatabaseContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDatabaseContext"/> class.
        /// </summary>
        /// <param name="options">The UserDatabaseContext</param>
        public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets and sets the Employee
        /// </summary>
        public DbSet<Employee> Employee { get; set; }
    }
}
