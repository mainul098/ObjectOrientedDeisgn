// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISubject.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   ISubject.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer
{
    /// <summary>
    ///     The class 1.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// The register observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// The remove observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        void RemoveObserver(IObserver observer);

        /// <summary>
        /// The notify observer.
        /// </summary>
        void NotifyObserver();
    }
}