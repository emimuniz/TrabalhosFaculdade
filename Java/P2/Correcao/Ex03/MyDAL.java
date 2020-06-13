/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpsemana11;

import java.lang.reflect.*;


public class MyDAL {

public static void geraTabela(Object obj)
{
Field[] f  = obj.getClass().getDeclaredFields();
String sql = "Create Table Tab" + obj.getClass().getSimpleName() + " (";


for(int i=0; i<f.length; ++i)
{
    sql += f[i].getName() + " " + (f[i].getType().getSimpleName().equals("String")?"varchar(60)":f[i].getType());
    if (i!=(f.length-1)) sql = sql + ", ";
}
sql += ")";
System.out.println(sql);
}

public static void set(Object obj)
{
Field[] f  = obj.getClass().getDeclaredFields();
String sql = "Insert Into Tab" + obj.getClass().getSimpleName() + " (";
Method mtd;

for(int i=0; i<f.length; ++i)
{
    sql += f[i].getName();
    if (i!=(f.length-1)) sql = sql + ", ";
}
sql += ") values (";
for(int i=0; i<f.length; ++i)
{
    try
    {
    String aux = "get" + f[i].getName().substring(0,1).toUpperCase() + f[i].getName().substring(1);
    mtd = obj.getClass().getMethod(aux);
    
    if (f[i].getType().getSimpleName().equals("String"))  
        sql += "'" + mtd.invoke(obj) + "'";
    else
        sql += mtd.invoke(obj);
    }
    catch(Exception e) {}
    if (i!=(f.length-1)) sql = sql + ", ";
}
sql += ")";
System.out.println(sql);
}

}
