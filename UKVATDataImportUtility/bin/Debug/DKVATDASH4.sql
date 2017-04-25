WITH RC1 AS
(SELECT CTCO, CTLOTNBR, (CTAG * 0.01) AS CT_AMT
FROM COPDTA.F55INT
WHERE CTGLFCAT = 'PUR'
AND CTGLFTYP = 'VAT'
AND ((CTDI# * 1000000) + (CTDIY * 10000) + (CTDIM * 100) + (CTDID)) BETWEEN 20000101 AND EndDate
AND SUBSTRING(CTCO,1,3) = '004'
AND CTCO NOT IN ('00470', '00471', '00475', '00480'))
SELECT CTLOTNBR AS LOT, SUM(CT_AMT) AS AMOUNT
FROM RC1
GROUP BY CTLOTNBR