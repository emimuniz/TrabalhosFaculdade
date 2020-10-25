<?xml version = "1.0" encoding = "UTF-8"?> 
<xsl:stylesheet version = "1.0" xmlns:xsl = "http://www.w3.org/1999/XSL/Transform">   
   <xsl:template match = "/movimento"> 
      <html> 
         <body> 
            <h2>Voos</h2> 
            <xsl:apply-templates select = "voo" /> 
         </body> 
      </html> 
   </xsl:template>  

   <xsl:template match = "voo"> 
      <xsl:apply-templates select = "@codigo" /> 
      <xsl:apply-templates select = "origem" /> 
      <xsl:apply-templates select = "destino" /> 
      <xsl:apply-templates select = "horario" /> 
      <xsl:apply-templates select = "operando" /> 
      <hr /> 
   </xsl:template>  

   <xsl:template match = "@codigo"> 
      <span style = "font-size = 22px;"> 
         <xsl:value-of select = "." /> 
      </span> 
      <br /> 
   </xsl:template>  

   <xsl:template match = "origem"> 
      Origem:<span style = "color:blue;"> 
         <xsl:value-of select = "." /> 
      </span> 
      <br /> 
   </xsl:template>  

   <xsl:template match = "destino"> 
      Destino:<span style = "color:green;"> 
         <xsl:value-of select = "." /> 
      </span> 
      <br /> 
   </xsl:template>  

   <xsl:template match = "horario"> 
     Horario:<span style = "color:red;"> 
         <xsl:value-of select = "." /> 
      </span> 
      <br /> 
   </xsl:template>  

   <xsl:template match = "operando"> 
     Operando:<span style = "color:gray;"> 
         <xsl:value-of select = "." /> 
      </span> 
      <br /> 
   </xsl:template>  
	
</xsl:stylesheet>