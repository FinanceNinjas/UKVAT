SELECT LBYRDNBR AS YARD, LBLOTNBR AS LOT, LBHIBID AS HIBID, (LBBUYAMT - LBHIBID) AS BUYFEE, (LBSLRCRG - LBACGTOT) AS SELLFEE, LTSCPNBR AS CPN, LTSLRNBR AS CODE, 
LBCPGCAT AS CONTRACT, LBCPGNBR AS NBR, 
((LBINVCCC * 1000000) + (LBINVYYY * 10000) + (LBINVMMM * 100) + (LBINVDDD)) AS INVDATE, LBCPGREV AS PROGRAM, LBTOWFEE AS TOW, LBPURAMT AS PURCHASE, LTFLG2UD AS VATFLAG,
STSTLDES AS TITLE
FROM GBRPRDDB.LOTBILLB
JOIN GBRPRDDB.LOTLT ON
LBLOTNBR = LTLOTNBR
JOIN GBRPRDDB.CASHSTST ON
LBLOTNBR = STLOT#
WHERE ((LBINVCCC * 1000000) + (LBINVYYY * 10000) + (LBINVMMM * 100) + (LBINVDDD)) BETWEEN StartDate AND EndDate AND
LTACLTYP = ' ' AND
LTYRDNBR NOT IN (470, 471, 475, 480)
ORDER BY LBLOTNBR
