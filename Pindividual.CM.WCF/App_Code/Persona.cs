using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de Persona
/// </summary>
public class Persona
{
    String nombre;
    String cedula;
    // DataMember
    public Persona()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    [DataMember]
    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }
    [DataMember]
    public string Cedula
    {
        get
        {
            return cedula;
        }

        set
        {
            cedula = value;
        }
    }
}