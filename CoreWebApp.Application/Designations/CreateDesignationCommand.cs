using CoreWebApp.Application.Interfaces;
using CoreWebApp.Core.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWebApp.Application.Designations {
    public class CreateDesignationCommand : IRequest<Guid> {
        public string Name { get; set; }
    }

    public class CreateDesignationCommandHandler : IRequestHandler<CreateDesignationCommand, Guid> {
        private readonly ICoreWebAppContext _context;

        public CreateDesignationCommandHandler(ICoreWebAppContext context) {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDesignationCommand request, CancellationToken cancellationToken) {
            var entity = new Designation() {
                Name = request.Name
            };

            _context.Designation.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }

    public class CreateDesignationCommandValidator : AbstractValidator<CreateDesignationCommand> {
        private readonly ICoreWebAppContext _context;
        public CreateDesignationCommandValidator(ICoreWebAppContext context) {
            RuleFor(v => v.Name)
                .MaximumLength(50)
                .NotEmpty()
                .MustAsync(Unique)
                .WithMessage("The specified designation already exists.");

        }

        public async Task<bool> Unique(string designation, CancellationToken cancellationToken) {
            return await _context.Designation.AllAsync(d => d.Name.Equals(designation, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
