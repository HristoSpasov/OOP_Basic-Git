using SimpleJudje.Exceptions;
using System;

namespace SimpleJudje.IO
{
    public abstract class Command
    {
        private string input;
        private string[] data;
        private Tester judge;
        private StudentRepository repository;
        private IOManager inputOutputManager;

        protected Command(string input, string[] data, Tester judge, StudentRepository repository, IOManager inputOutputManagar)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManagar;
        }

        protected string Input
        {
            get { return this.input; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.input = value;
            }
        }

        protected string[] Data
        {
            get { return this.data; }

            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }

                this.data = value;
            }
        }

        protected Tester Judge
        {
            get { return this.judge; }
        }

        protected StudentRepository Repository
        {
            get { return this.repository; }
        }

        protected IOManager InputOutputManager
        {
            get { return this.inputOutputManager; }
        }

        public abstract void Execute();
    }
}