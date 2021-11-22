: d2 ( n -- n ) 2 / ;
see d2
: s2 ( -- ) CR ." hello World" CR ;
s2
S" pwd" system
include test_forth.fs
see div
( S" vim ~/.gforth-history" system )
( include gforth.fs )

: in-ascii ( n -- n ) cr .s cr ." ASCII of value " dup . ." is " dup emit cr .s cr ;  
102 in-ascii

: is_stack_top_0? cr .s cr dup 0 = if ." top is 0" else  ." top is not 0" then cr .s cr ;

15 is_stack_top_0?

invert
4 3 > invert
dup
rot ( 3 elements rotate)
drop

: hi_x_10b crs 10 0 do i ." hi " drop i 120 + crs  loop ;

: crs cr .s cr ;                                                

: loop-test crs begin 1 - dup dup . 0 = until crs ;  ok
 20 loop-test
( 0 loop-test ( forever loop control-c )  )

: asciis 0 [char] a [char] b [char] c [char] d begin crs dup dup . emit 0 = until ;

