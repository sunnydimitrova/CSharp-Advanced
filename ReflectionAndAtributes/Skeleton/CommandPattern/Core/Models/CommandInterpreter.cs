using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = 
                args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandName = input[0] + "Command";

            string[] comandArguments = 
                input.Skip(1)
                .ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == commandName.ToLower());

            if (commandType == null)
            {
                throw new Exception("Inavlid command type!");
            }

            ICommand commandInstance = (ICommand)Activator.CreateInstance(commandType);

            var result = commandInstance.Execute(comandArguments);
            return result;
        }
    }
}
