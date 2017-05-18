// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndividualContributor.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The individual contributor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Composite
{
    /// <summary>
    /// The individual contributor.
    /// </summary>
    public class IndividualContributor : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualContributor"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public IndividualContributor(string name)
            : base(name)
        {
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        public override void Add(Employee employee)
        {
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="employee">
        /// The employee.
        /// </param>
        public override void Remove(Employee employee)
        {
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