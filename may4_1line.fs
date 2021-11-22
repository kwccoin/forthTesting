( https://raw.githubusercontent.com/susam/may4/master/may4.fs)
: stars
   0  do  [char] * emit  loop  ;

: lines
   0  do  cr  loop  ;

: print
   dup 40 > if  40 - lines  else
   dup 20 > if  20 - spaces  else
      stars
   then then  ;

: start
   0  do  print  loop  ;


41 11 37 11 36 5 28 41 5 27 5
1  26 3 25  3

depth
1-
 ( and you do not need to calculate by hand but use depth 1-) ( 16) ( the last number 16 is total numbers used -1 like 473)
( and read reverse it should say 16+1 number as counted from 0 
and 3 star, 5 stars, 3 stars ... last is 1 star; remove 20/40 as needed)

start
bye
