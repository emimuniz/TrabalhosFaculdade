<?xml version="1.0" encoding="ISO-8859-1" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/movimento">
<html>
<body>
   Quantidade: <xsl:value-of select="count(*)"/>
<br/>
<br/>
<table border="1">
	<tr bgcolor = "#9acd32">
	    <th>Origem</th>
	    <th>Destino</th>
	    <th>Horario</th>
	    <th>Compania</th>
	    <th>Operando</th>	
	</tr>

	<xsl:for-each select="voo">
	<tr>   
         <xsl:choose>
         <xsl:when test = "(position() mod 2) = 0">
            <td bgcolor="#696969"><xsl:value-of select="origem"/></td>
            <td bgcolor="#696969"><xsl:value-of select="destino"/></td>
            <td bgcolor="#696969"><xsl:value-of select="horario"/></td>
            <td bgcolor="#696969"><xsl:value-of select="compania"/></td>
            <td bgcolor="#696969"><xsl:value-of select="operando"/></td>
         </xsl:when>
         <xsl:otherwise>
            <td bgcolor="#DCDCDC"><xsl:value-of select="origem"/></td>
            <td bgcolor="#DCDCDC"><xsl:value-of select="destino"/></td>
            <td bgcolor="#DCDCDC"><xsl:value-of select="horario"/></td>
            <td bgcolor="#DCDCDC"><xsl:value-of select="compania"/></td>
            <td bgcolor="#DCDCDC"><xsl:value-of select="operando"/></td>
         </xsl:otherwise>
      </xsl:choose>
	</tr>
	</xsl:for-each>
</table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>