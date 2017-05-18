// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Manager.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Composite
{
    using System.Collections.Generic;

    /// <summary>
    /// The manager.
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// The direct reports.
        /// </summary>
        private readonly IList<Employee> directReports = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Manager(string name)
            : base(name)
        {
            this.directReports = new List<Employee>();
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        public override void Add(Employee employee)
        {
            this.directReports.Add(employee);
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        public override void Remove(Employee employee)
        {
            this.directReports.Remove(employee);
        }

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="depth">
        /// The depth.
        /// </param>
        public override void Display(int depth)
        {
        }
    }
}