<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="html"/>
 
<xsl:template match="/">
  <HTML>
    <BODY>
      <p>
        <H2>Flights' timetable</H2> </p>      
    </BODY>
    <BODY>
      <TABLE BORDER="2">
        <TR>
          <TH>
            <b>Departure</b>
          </TH>
         <TH>
            <b>Arrival</b>
          </TH>
          <TH>
            <b>Date</b>
          </TH>
          <TH>
            <b>Price (UAH)</b>
          </TH>
          <TH>
            <B>Duration (hours)</B>
          </TH>
          <TH>
            <B>Airline</B>
          </TH>
          <TH>
            <B>Include Lunch</B>
          </TH>
          <TH>
            <B>Tour Operator</B>
          </TH>
        </TR>
        <xsl:for-each select="Plane/flight">
          <TR>
            <TD>
              <xsl:value-of select="@Departure"/>
            </TD>
            <TD>
              <xsl:value-of select="@Arrival"/>
            </TD>
            <TD>
              <xsl:value-of select="@Date"/>
            </TD>
            <TD>
              <xsl:value-of select="@Price"/>
            </TD>
            <TD>
              <xsl:value-of select="@Duration"/>
            </TD>
            <TD>
              <xsl:value-of select="@Airline"/>
            </TD>
            <TD>
              <xsl:value-of select="@IncludeLunch"/>
            </TD>
            <TD>
              <xsl:value-of select="@TourOperator"/>
            </TD>
          </TR>
        </xsl:for-each>
      </TABLE>
    </BODY>
  </HTML>
</xsl:template>
</xsl:stylesheet>
