<?xml version="1.0" encoding="ISO-8859-1" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/loja">
<html>
<body>
<table border="1">
	<tr  bgcolor = "#9acd32">
	    <th>Produto</th>
	    <th>Valor</th>
	    <th>Quantidade</th>
	</tr>

	<xsl:for-each select="pedido[quantidade&lt;3 and valor&gt; 10]">
	<tr>
            <td><xsl:value-of select="produto"/></td>
            <td><xsl:value-of select="valor"/></td>
            <td><xsl:value-of select="quantidade"/></td>
	</tr>
	</xsl:for-each>
</table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>