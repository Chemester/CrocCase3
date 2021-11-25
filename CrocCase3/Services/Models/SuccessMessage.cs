﻿using System;
using System.Collections.Generic;

namespace Services.Models
{
    /// <summary>
    /// Описывает модель выходных данных данных.
    /// </summary>
    public class SuccessMessage
    {
        /// <summary>
        /// Успешность выполнения задания.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Причина неудачного выполнения задания.
        /// </summary>
        public List<string> Reason { get; } = new();
    }
}