<?xml version="1.0" encoding="ISO-8859-1" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/movimento">
<html>
<body>
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
            <td><xsl:value-of select="origem"/></td>
            <td><xsl:value-of select="destino"/></td>
            <td><xsl:value-of select="horario"/></td>
            <td><xsl:value-of select="compania"/></td>
	          <xsl:choose>
               <xsl:when test = "operando = 'F'">
                  <td bgcolor="#696969">
                     NAO
                  </td>
               </xsl:when>
               <xsl:otherwise>
                  <td  bgcolor="#DCDCDC">SIM</td>
               </xsl:otherwise>
            </xsl:choose>
	</tr>
	</xsl:for-each>
</table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>