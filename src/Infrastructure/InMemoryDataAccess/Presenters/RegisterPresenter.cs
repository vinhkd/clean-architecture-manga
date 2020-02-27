namespace Infrastructure.InMemoryDataAccess.Presenters
{
    using System.Collections.ObjectModel;
    using Application.Boundaries.Register;

    /// <summary>
    ///
    /// </summary>
    public sealed class RegisterPresenter : IOutputPort
    {
        /// <summary>
        ///
        /// </summary>
        public RegisterPresenter()
        {
            this.Registers = new Collection<RegisterOutput>();
            this.AlreadyRegistered = new Collection<string>();
            this.Errors = new Collection<string>();
        }

        /// <summary>
        ///
        /// </summary>
        public Collection<RegisterOutput> Registers { get; }

        /// <summary>
        ///
        /// </summary>
        public Collection<string> AlreadyRegistered { get; }

        /// <summary>
        ///
        /// </summary>
        public Collection<string> Errors { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="output"></param>
        public void Standard(RegisterOutput output)
        {
            this.Registers.Add(output);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        public void CustomerAlreadyRegistered(string message)
        {
            this.AlreadyRegistered.Add(message);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        public void WriteError(string message)
        {
            this.Errors.Add(message);
        }
    }
}
