using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace _06.razor02.layout.Models
{
    public class FileExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        private readonly string _errorMessage;

        public FileExtensionsAttribute(string[] _extensions, string errorMessage)
        {
            this._extensions = _extensions;
            this._errorMessage = errorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            var file = value as IFormFile;

            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult(GetErrorMessage());
                }

            }

            return ValidationResult.Success;
        }
        public string GetErrorMessage()
        {
            return _errorMessage;
        }
    }
}
