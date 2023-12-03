﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesApp
{
    public interface ISerializable<T>
    {
        bool Serializar(T datos);
        List<T> Deserializar();
    }
} 