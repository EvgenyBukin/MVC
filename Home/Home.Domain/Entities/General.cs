﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Home.Domain.Entities
{
    public class General
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ModuleId { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Пожалуйста, введите данные")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Заголовочное описание")]
        [Required(ErrorMessage = "Пожалуйста, введите данные")]
        public string DescriptionHeader { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите данные")]
        public string DescriptionBody { get; set; }

        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Пожалуйста, введите данные")]
        public string Category { get; set; }

        [Display(Name = "Путь к изображению")]
        [Required(ErrorMessage = "Пожалуйста, введите данные")]
        public string Img1 { get; set; }

        [Display(Name = "Путь к изображению")]
        [Required(ErrorMessage = "Пожалуйста, введите данные")]
        public string Img2 { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img3 { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img4 { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img5 { get; set; }

        [Display(Name = "Путь к изображению")]
        public string Img6 { get; set; }

        [Display(Name = "Путь к видио")]
        public string video { get; set; }

        [HiddenInput(DisplayValue = false)]
        //[Display(Name = "Дата")]
        public DateTime Data { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
