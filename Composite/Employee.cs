// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The employee.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Composite
{
    /// <summary>
    /// The employee.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        protected Employee(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        public abstract void Add(Employee employee);

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        public abstract void Remove(Employee employee);

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="depth">
        /// The depth.
        /// </param>
        public abstract void Display(int depth);
    }
}