
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WCF_Matriculas
{

using System;
    using System.Collections.Generic;
    
public partial class Tb_ALUMNO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tb_ALUMNO()
    {

        this.Tb_MATRICULA = new HashSet<Tb_MATRICULA>();

        this.Tb_CUOTA = new HashSet<Tb_CUOTA>();

    }


    public int Id_alum { get; set; }

    public string Id_Ubigeo { get; set; }

    public string Dni_alum { get; set; }

    public byte[] Foto_alum { get; set; }

    public Nullable<System.DateTime> Fec_nac { get; set; }

    public string Sexo { get; set; }

    public string Nom_alum { get; set; }

    public string Ape_alum { get; set; }

    public string Dir_alum { get; set; }

    public string Tel_alum { get; set; }

    public string Email_alum { get; set; }

    public string Usu_Registro { get; set; }

    public System.DateTime Fec_reg { get; set; }

    public string Usu_Ult_Mod { get; set; }

    public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }

    public Nullable<int> Est_alum { get; set; }



    public virtual Tb_Ubigeo Tb_Ubigeo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_MATRICULA> Tb_MATRICULA { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_CUOTA> Tb_CUOTA { get; set; }

}

}
