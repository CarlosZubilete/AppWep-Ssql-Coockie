using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_SQL_Cookies.connection
{
  public class Producto
  {
    public Producto() { } 
    
    public Producto(int id, string name, string cantXunidad, float precioUnidad)
    {
      _id = id;
      _name = name; 
      _cantXunidad = cantXunidad;
      _precioUnidad = precioUnidad;
    }

    // SETTERS Y GETTERS
    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        _id = value;
      }
    }
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }
    public string CantXUnidad
    {
      get
      {
        return _cantXunidad;
      }
      set
      {
        _cantXunidad = value;
      }
    }
    public float PrecioUnidad
    {
      get
      {
        return _precioUnidad;
      }
      set
      {
        _precioUnidad = value;
      }
    }

    int _id;
    string _name; 
    string _cantXunidad;
    float _precioUnidad;    
  }
}