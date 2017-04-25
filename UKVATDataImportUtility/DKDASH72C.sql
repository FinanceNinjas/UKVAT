SELECT LTYRDNBR AS YARD, LTSLRNBR AS SELLER, LTLOTNBR AS LOT, LBHIBID AS HIBID, (LBCPGREV + LBTOWFEE) AS PROGREV, LTLOTMDL AS LOTMODEL
FROM GBRPRDDB.LOTLT
JOIN GBRPRDDB.LOTBILLB ON
LTLOTNBR = LBLOTNBR
JOIN GBRPRDDB.SELLERSO ON
LTSLRNBR = SOSLRNBR
WHERE ((LBINVCCC * 1000000) + (LBINVYYY * 10000) + (LBINVMMM * 100) + (LBINVDDD)) BETWEEN StartDate AND EndDate AND
LBCPGCAT <> 'PPP' AND
LTSCPNBR = 'COP' AND
LTACLTYP = ' ' AND
LTYRDNBR NOT IN (451, 452, 470, 471, 475, 480) AND
LTSLRNBR <> 'C100'
ORDER BY LTYRDNBR, LTLOTNBR