<<<<<<< .mine��n a m e s p a c e   Q u a n L y T h i N g h e . F o r m s  
 {  
         p a r t i a l   c l a s s   f r m C h i a H o i D o n g T h i  
         {  
                 / / /   < s u m m a r y >  
                 / / /   R e q u i r e d   d e s i g n e r   v a r i a b l e .  
                 / / /   < / s u m m a r y >  
                 p r i v a t e   S y s t e m . C o m p o n e n t M o d e l . I C o n t a i n e r   c o m p o n e n t s   =   n u l l ;  
  
                 / / /   < s u m m a r y >  
                 / / /   C l e a n   u p   a n y   r e s o u r c e s   b e i n g   u s e d .  
                 / / /   < / s u m m a r y >  
                 / / /   < p a r a m   n a m e = " d i s p o s i n g " > t r u e   i f   m a n a g e d   r e s o u r c e s   s h o u l d   b e   d i s p o s e d ;   o t h e r w i s e ,   f a l s e . < / p a r a m >  
                 p r o t e c t e d   o v e r r i d e   v o i d   D i s p o s e ( b o o l   d i s p o s i n g )  
                 {  
                         i f   ( d i s p o s i n g   & &   ( c o m p o n e n t s   ! =   n u l l ) )  
                         {  
                                 c o m p o n e n t s . D i s p o s e ( ) ;  
                         }  
                         b a s e . D i s p o s e ( d i s p o s i n g ) ;  
                 }  
  
                 # r e g i o n   W i n d o w s   F o r m   D e s i g n e r   g e n e r a t e d   c o d e  
  
                 / / /   < s u m m a r y >  
                 / / /   R e q u i r e d   m e t h o d   f o r   D e s i g n e r   s u p p o r t   -   d o   n o t   m o d i f y  
                 / / /   t h e   c o n t e n t s   o f   t h i s   m e t h o d   w i t h   t h e   c o d e   e d i t o r .  
                 / / /   < / s u m m a r y >  
                 p r i v a t e   v o i d   I n i t i a l i z e C o m p o n e n t ( )  
                 {  
                         t h i s . t a b l e L a y o u t P a n e l 1   =   n e w   S y s t e m . W i n d o w s . F o r m s . T a b l e L a y o u t P a n e l ( ) ;  
                         t h i s . t r e e L i s t T r u o n g   =   n e w   D e v E x p r e s s . X t r a T r e e L i s t . T r e e L i s t ( ) ;  
                         t h i s . t r e e L i s t H D T   =   n e w   D e v E x p r e s s . X t r a T r e e L i s t . T r e e L i s t ( ) ;  
                         t h i s . s i m p l e B u t t o n L u u   =   n e w   D e v E x p r e s s . X t r a E d i t o r s . S i m p l e B u t t o n ( ) ;  
                         t h i s . c o m b o B o x K y T h i   =   n e w   S y s t e m . W i n d o w s . F o r m s . C o m b o B o x ( ) ;  
                         t h i s . r a d i o B u t t o n 1   =   n e w   S y s t e m . W i n d o w s . F o r m s . R a d i o B u t t o n ( ) ;  
                         t h i s . r a d i o B u t t o n 2   =   n e w   S y s t e m . W i n d o w s . F o r m s . R a d i o B u t t o n ( ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . S u s p e n d L a y o u t ( ) ;  
                         ( ( S y s t e m . C o m p o n e n t M o d e l . I S u p p o r t I n i t i a l i z e ) ( t h i s . t r e e L i s t T r u o n g ) ) . B e g i n I n i t ( ) ;  
                         ( ( S y s t e m . C o m p o n e n t M o d e l . I S u p p o r t I n i t i a l i z e ) ( t h i s . t r e e L i s t H D T ) ) . B e g i n I n i t ( ) ;  
                         t h i s . S u s p e n d L a y o u t ( ) ;  
                         / /    
                         / /   t a b l e L a y o u t P a n e l 1  
                         / /    
                         t h i s . t a b l e L a y o u t P a n e l 1 . A n c h o r   =   ( ( S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s ) ( ( ( ( S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s . T o p   |   S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s . B o t t o m )  
                                                 |   S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s . L e f t )  
                                                 |   S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s . R i g h t ) ) ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . C o l u m n C o u n t   =   2 ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . C o l u m n S t y l e s . A d d ( n e w   S y s t e m . W i n d o w s . F o r m s . C o l u m n S t y l e ( S y s t e m . W i n d o w s . F o r m s . S i z e T y p e . P e r c e n t ,   5 0 F ) ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . C o l u m n S t y l e s . A d d ( n e w   S y s t e m . W i n d o w s . F o r m s . C o l u m n S t y l e ( S y s t e m . W i n d o w s . F o r m s . S i z e T y p e . P e r c e n t ,   5 0 F ) ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . C o n t r o l s . A d d ( t h i s . t r e e L i s t T r u o n g ,   0 ,   0 ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . C o n t r o l s . A d d ( t h i s . t r e e L i s t H D T ,   0 ,   0 ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 0 ,   2 7 ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . N a m e   =   " t a b l e L a y o u t P a n e l 1 " ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . R o w C o u n t   =   1 ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . R o w S t y l e s . A d d ( n e w   S y s t e m . W i n d o w s . F o r m s . R o w S t y l e ( S y s t e m . W i n d o w s . F o r m s . S i z e T y p e . P e r c e n t ,   5 0 F ) ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . R o w S t y l e s . A d d ( n e w   S y s t e m . W i n d o w s . F o r m s . R o w S t y l e ( S y s t e m . W i n d o w s . F o r m s . S i z e T y p e . A b s o l u t e ,   5 1 4 F ) ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 8 1 7 ,   5 1 4 ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . T a b I n d e x   =   0 ;  
                         / /    
                         / /   t r e e L i s t T r u o n g  
                         / /    
                         t h i s . t r e e L i s t T r u o n g . D o c k   =   S y s t e m . W i n d o w s . F o r m s . D o c k S t y l e . F i l l ;  
                         t h i s . t r e e L i s t T r u o n g . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 4 1 1 ,   3 ) ;  
                         t h i s . t r e e L i s t T r u o n g . N a m e   =   " t r e e L i s t T r u o n g " ;  
                         t h i s . t r e e L i s t T r u o n g . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 4 0 3 ,   5 0 8 ) ;  
                         t h i s . t r e e L i s t T r u o n g . T a b I n d e x   =   0 ;  
                         t h i s . t r e e L i s t T r u o n g . F o c u s e d N o d e C h a n g e d   + =   n e w   D e v E x p r e s s . X t r a T r e e L i s t . F o c u s e d N o d e C h a n g e d E v e n t H a n d l e r ( t h i s . t r e e L i s t T r u o n g _ F o c u s e d N o d e C h a n g e d ) ;  
                         / /    
                         / /   t r e e L i s t H D T  
                         / /    
                         t h i s . t r e e L i s t H D T . C u s t o m i z a t i o n F o r m B o u n d s   =   n e w   S y s t e m . D r a w i n g . R e c t a n g l e ( 3 8 9 ,   3 2 7 ,   2 0 8 ,   1 6 8 ) ;  
                         t h i s . t r e e L i s t H D T . D o c k   =   S y s t e m . W i n d o w s . F o r m s . D o c k S t y l e . F i l l ;  
                         t h i s . t r e e L i s t H D T . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 3 ,   3 ) ;  
                         t h i s . t r e e L i s t H D T . N a m e   =   " t r e e L i s t H D T " ;  
                         t h i s . t r e e L i s t H D T . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 4 0 2 ,   5 0 8 ) ;  
                         t h i s . t r e e L i s t H D T . T a b I n d e x   =   1 ;  
                         / /    
                         / /   s i m p l e B u t t o n L u u  
                         / /    
                         t h i s . s i m p l e B u t t o n L u u . A n c h o r   =   ( ( S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s ) ( ( S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s . T o p   |   S y s t e m . W i n d o w s . F o r m s . A n c h o r S t y l e s . R i g h t ) ) ) ;  
                         t h i s . s i m p l e B u t t o n L u u . I m a g e   =   g l o b a l : : Q u a n L y T h i N g h e . P r o p e r t i e s . R e s o u r c e s . p i n ;  
                         t h i s . s i m p l e B u t t o n L u u . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 6 9 6 ,   2 ) ;  
                         t h i s . s i m p l e B u t t o n L u u . N a m e   =   " s i m p l e B u t t o n L u u " ;  
                         t h i s . s i m p l e B u t t o n L u u . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 1 1 8 ,   2 3 ) ;  
                         t h i s . s i m p l e B u t t o n L u u . T a b I n d e x   =   3 ;  
                         t h i s . s i m p l e B u t t o n L u u . T e x t   =   " C h i a   h �i   �n g   t h i " ;  
                         / /    
                         / /   c o m b o B o x K y T h i  
                         / /    
                         t h i s . c o m b o B o x K y T h i . D i s p l a y M e m b e r   =   " T e n K y T h i " ;  
                         t h i s . c o m b o B o x K y T h i . F o r m a t t i n g E n a b l e d   =   t r u e ;  
                         t h i s . c o m b o B o x K y T h i . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 3 ,   4 ) ;  
                         t h i s . c o m b o B o x K y T h i . N a m e   =   " c o m b o B o x K y T h i " ;  
                         t h i s . c o m b o B o x K y T h i . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 2 6 8 ,   2 1 ) ;  
                         t h i s . c o m b o B o x K y T h i . T a b I n d e x   =   4 ;  
                         t h i s . c o m b o B o x K y T h i . V a l u e M e m b e r   =   " M a K y T h i " ;  
                         / /    
                         / /   r a d i o B u t t o n 1  
                         / /    
                         t h i s . r a d i o B u t t o n 1 . A u t o S i z e   =   t r u e ;  
                         t h i s . r a d i o B u t t o n 1 . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 2 7 9 ,   7 ) ;  
                         t h i s . r a d i o B u t t o n 1 . N a m e   =   " r a d i o B u t t o n 1 " ;  
                         t h i s . r a d i o B u t t o n 1 . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 5 1 ,   1 7 ) ;  
                         t h i s . r a d i o B u t t o n 1 . T a b I n d e x   =   5 ;  
                         t h i s . r a d i o B u t t o n 1 . T a b S t o p   =   t r u e ;  
                         t h i s . r a d i o B u t t o n 1 . T e x t   =   " T H C S " ;  
                         t h i s . r a d i o B u t t o n 1 . U s e V i s u a l S t y l e B a c k C o l o r   =   t r u e ;  
                         / /    
                         / /   r a d i o B u t t o n 2  
                         / /    
                         t h i s . r a d i o B u t t o n 2 . A u t o S i z e   =   t r u e ;  
                         t h i s . r a d i o B u t t o n 2 . C h e c k e d   =   t r u e ;  
                         t h i s . r a d i o B u t t o n 2 . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 3 3 5 ,   7 ) ;  
                         t h i s . r a d i o B u t t o n 2 . N a m e   =   " r a d i o B u t t o n 2 " ;  
                         t h i s . r a d i o B u t t o n 2 . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 5 0 ,   1 7 ) ;  
                         t h i s . r a d i o B u t t o n 2 . T a b I n d e x   =   6 ;  
                         t h i s . r a d i o B u t t o n 2 . T a b S t o p   =   t r u e ;  
                         t h i s . r a d i o B u t t o n 2 . T e x t   =   " T H P T " ;  
                         t h i s . r a d i o B u t t o n 2 . U s e V i s u a l S t y l e B a c k C o l o r   =   t r u e ;  
                         / /    
                         / /   f r m C h i a H o i D o n g T h i  
                         / /    
                         t h i s . A u t o S c a l e D i m e n s i o n s   =   n e w   S y s t e m . D r a w i n g . S i z e F ( 6 F ,   1 3 F ) ;  
                         t h i s . A u t o S c a l e M o d e   =   S y s t e m . W i n d o w s . F o r m s . A u t o S c a l e M o d e . F o n t ;  
                         t h i s . C l i e n t S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 8 1 7 ,   5 4 2 ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . r a d i o B u t t o n 2 ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . r a d i o B u t t o n 1 ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . c o m b o B o x K y T h i ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . s i m p l e B u t t o n L u u ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . t a b l e L a y o u t P a n e l 1 ) ;  
                         t h i s . N a m e   =   " f r m C h i a H o i D o n g T h i " ;  
                         t h i s . T e x t   =   " C h i a   h �i   �n g   t h i " ;  
                         t h i s . L o a d   + =   n e w   S y s t e m . E v e n t H a n d l e r ( t h i s . f r m C h i a H o i D o n g T h i _ L o a d ) ;  
                         t h i s . t a b l e L a y o u t P a n e l 1 . R e s u m e L a y o u t ( f a l s e ) ;  
                         ( ( S y s t e m . C o m p o n e n t M o d e l . I S u p p o r t I n i t i a l i z e ) ( t h i s . t r e e L i s t T r u o n g ) ) . E n d I n i t ( ) ;  
                         ( ( S y s t e m . C o m p o n e n t M o d e l . I S u p p o r t I n i t i a l i z e ) ( t h i s . t r e e L i s t H D T ) ) . E n d I n i t ( ) ;  
                         t h i s . R e s u m e L a y o u t ( f a l s e ) ;  
                         t h i s . P e r f o r m L a y o u t ( ) ;  
  
                 }  
  
                 # e n d r e g i o n  
  
                 p r i v a t e   S y s t e m . W i n d o w s . F o r m s . T a b l e L a y o u t P a n e l   t a b l e L a y o u t P a n e l 1 ;  
                 p r i v a t e   D e v E x p r e s s . X t r a T r e e L i s t . T r e e L i s t   t r e e L i s t T r u o n g ;  
                 p r i v a t e   D e v E x p r e s s . X t r a T r e e L i s t . T r e e L i s t   t r e e L i s t H D T ;  
                 p r i v a t e   D e v E x p r e s s . X t r a E d i t o r s . S i m p l e B u t t o n   s i m p l e B u t t o n L u u ;  
                 p r i v a t e   S y s t e m . W i n d o w s . F o r m s . C o m b o B o x   c o m b o B o x K y T h i ;  
                 p r i v a t e   S y s t e m . W i n d o w s . F o r m s . R a d i o B u t t o n   r a d i o B u t t o n 1 ;  
                 p r i v a t e   S y s t e m . W i n d o w s . F o r m s . R a d i o B u t t o n   r a d i o B u t t o n 2 ;  
  
  
         }  
 } =======��n a m e s p a c e   Q u a n L y T h i N g h e . F o r m s  
 {  
         p a r t i a l   c l a s s   f r m C h i a H o i D o n g T h i  
         {  
                 / / /   < s u m m a r y >  
                 / / /   R e q u i r e d   d e s i g n e r   v a r i a b l e .  
                 / / /   < / s u m m a r y >  
                 p r i v a t e   S y s t e m . C o m p o n e n t M o d e l . I C o n t a i n e r   c o m p o n e n t s   =   n u l l ;  
  
                 / / /   < s u m m a r y >  
                 / / /   C l e a n   u p   a n y   r e s o u r c e s   b e i n g   u s e d .  
                 / / /   < / s u m m a r y >  
                 / / /   < p a r a m   n a m e = " d i s p o s i n g " > t r u e   i f   m a n a g e d   r e s o u r c e s   s h o u l d   b e   d i s p o s e d ;   o t h e r w i s e ,   f a l s e . < / p a r a m >  
                 p r o t e c t e d   o v e r r i d e   v o i d   D i s p o s e ( b o o l   d i s p o s i n g )  
                 {  
                         i f   ( d i s p o s i n g   & &   ( c o m p o n e n t s   ! =   n u l l ) )  
                         {  
                                 c o m p o n e n t s . D i s p o s e ( ) ;  
                         }  
                         b a s e . D i s p o s e ( d i s p o s i n g ) ;  
                 }  
  
                 # r e g i o n   W i n d o w s   F o r m   D e s i g n e r   g e n e r a t e d   c o d e  
  
                 / / /   < s u m m a r y >  
                 / / /   R e q u i r e d   m e t h o d   f o r   D e s i g n e r   s u p p o r t   -   d o   n o t   m o d i f y  
                 / / /   t h e   c o n t e n t s   o f   t h i s   m e t h o d   w i t h   t h e   c o d e   e d i t o r .  
                 / / /   < / s u m m a r y >  
                 p r i v a t e   v o i d   I n i t i a l i z e C o m p o n e n t ( )  
                 {  
                         t h i s . t r e e V i e w 1   =   n e w   S y s t e m . W i n d o w s . F o r m s . T r e e V i e w ( ) ;  
                         t h i s . t r e e V i e w 2   =   n e w   S y s t e m . W i n d o w s . F o r m s . T r e e V i e w ( ) ;  
                         t h i s . S u s p e n d L a y o u t ( ) ;  
                         / /    
                         / /   t r e e V i e w 1  
                         / /    
                         t h i s . t r e e V i e w 1 . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 5 0 ,   2 3 ) ;  
                         t h i s . t r e e V i e w 1 . N a m e   =   " t r e e V i e w 1 " ;  
                         t h i s . t r e e V i e w 1 . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 3 0 5 ,   4 1 3 ) ;  
                         t h i s . t r e e V i e w 1 . T a b I n d e x   =   0 ;  
                         t h i s . t r e e V i e w 1 . I t e m D r a g   + =   n e w   S y s t e m . W i n d o w s . F o r m s . I t e m D r a g E v e n t H a n d l e r ( t h i s . t r e e V i e w 1 _ I t e m D r a g ) ;  
                         / /    
                         / /   t r e e V i e w 2  
                         / /    
                         t h i s . t r e e V i e w 2 . L o c a t i o n   =   n e w   S y s t e m . D r a w i n g . P o i n t ( 4 5 3 ,   2 3 ) ;  
                         t h i s . t r e e V i e w 2 . N a m e   =   " t r e e V i e w 2 " ;  
                         t h i s . t r e e V i e w 2 . S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 3 0 5 ,   4 1 3 ) ;  
                         t h i s . t r e e V i e w 2 . T a b I n d e x   =   1 ;  
                         t h i s . t r e e V i e w 2 . D r a g D r o p   + =   n e w   S y s t e m . W i n d o w s . F o r m s . D r a g E v e n t H a n d l e r ( t h i s . t r e e V i e w 2 _ D r a g D r o p ) ;  
                         t h i s . t r e e V i e w 2 . D r a g E n t e r   + =   n e w   S y s t e m . W i n d o w s . F o r m s . D r a g E v e n t H a n d l e r ( t h i s . t r e e V i e w 2 _ D r a g E n t e r ) ;  
                         / /    
                         / /   f r m C h i a H o i D o n g T h i  
                         / /    
                         t h i s . A u t o S c a l e D i m e n s i o n s   =   n e w   S y s t e m . D r a w i n g . S i z e F ( 6 F ,   1 3 F ) ;  
                         t h i s . A u t o S c a l e M o d e   =   S y s t e m . W i n d o w s . F o r m s . A u t o S c a l e M o d e . F o n t ;  
                         t h i s . C l i e n t S i z e   =   n e w   S y s t e m . D r a w i n g . S i z e ( 8 2 2 ,   5 3 4 ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . t r e e V i e w 2 ) ;  
                         t h i s . C o n t r o l s . A d d ( t h i s . t r e e V i e w 1 ) ;  
                         t h i s . N a m e   =   " f r m C h i a H o i D o n g T h i " ;  
                         t h i s . T e x t   =   " C h i a   h �i   �n g   t h i " ;  
                         t h i s . L o a d   + =   n e w   S y s t e m . E v e n t H a n d l e r ( t h i s . f r m C h i a H o i D o n g T h i _ L o a d ) ;  
                         t h i s . R e s u m e L a y o u t ( f a l s e ) ;  
  
                 }  
  
                 # e n d r e g i o n  
  
                 p r i v a t e   S y s t e m . W i n d o w s . F o r m s . T r e e V i e w   t r e e V i e w 1 ;  
                 p r i v a t e   S y s t e m . W i n d o w s . F o r m s . T r e e V i e w   t r e e V i e w 2 ;  
         }  
 } >>>>>>> .r89