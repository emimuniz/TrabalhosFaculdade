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
String sql = "Create Table Tab" + obj.getClass().getSimpleName() + " (";
Field[] f  = obj.getClass().getDeclaredFields();


for(int i=0; i<f.length; ++i)
{
    sql += f[i].getName() + " " + (f[i].getType().getSimpleName().equals("String")?"varchar(60)":f[i].getType());
    if (i!=(f.length-1)) sql = sql + ", ";
}
  sql += ")";
  System.out.println(sql);
}


}
