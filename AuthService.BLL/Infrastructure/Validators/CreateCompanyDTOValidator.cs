﻿using AuthService.BLL.DTOs.Implementations.Requests.Company;
using FluentValidation;

public class CreateCompanyDTOValidator : AbstractValidator<CreateCompanyDTO>
{
    public CreateCompanyDTOValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Название компании обязательно")
            .Length(2, 100).WithMessage("Длина названия компании должна быть от 2 до 100 символов");

        RuleFor(x => x.Unp)
            .NotEmpty().WithMessage("УНП обязателен")
            .InclusiveBetween(100000000, 999999999).WithMessage("УНП должен состоять из 9 цифр");

        RuleFor(x => x.LegalAddress)
            .NotEmpty().WithMessage("Юридический адрес обязателен")
            .MaximumLength(200).WithMessage("Максимальная длина юридического адреса 200 символов");

        RuleFor(x => x.PostalAddress)
            .NotEmpty().WithMessage("Почтовый адрес обязателен")
            .MaximumLength(200).WithMessage("Максимальная длина почтового адреса 200 символов");

        RuleFor(x => x.ResponsibleUserId)
            .NotEmpty().WithMessage("ID ответственного лица обязателен");
    }
}