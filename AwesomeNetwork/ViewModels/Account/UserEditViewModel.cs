﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AwesomeNetwork.ViewModels.Account
{
    public class UserEditViewModel
    {
        public string Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Имя", Prompt = "Введите имя")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Фамилия", Prompt = "Введите фамилию")]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Отчество", Prompt = "Введите отчество")]
        public string MiddleName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Фото", Prompt = "Укажите ссылку на картинку")]
        public string Image { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Статус", Prompt = "Введите статус")]
        public string Status { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "О себе", Prompt = "Введите данные о себе")]
        public string About { get; set; }

        [EmailAddress]
        [Display(Name = "Email", Prompt = "example.com")]
        public string Email { get; set; }

        public string UserName => Email;
    }
}
