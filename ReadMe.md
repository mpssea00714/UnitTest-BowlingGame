Unit Test - Bowling Game (保齡球比賽計分方式)

計分規則:計分單位是局(Game),每局共有十個計分格(Frame)。每個計分格最多有兩次投球(Roll)機會。若第一次投球就打倒全部球瓶(Pin),該次計分就計Strike(全倒),結束該次計分格;
         若第一次沒有全倒,則可以再投第二次,如果把剩下的球瓶全都擊倒就記Spare(補中)。

         如果擊出Strike則該次計分格的分數需要擊倒10瓶的10分+後面兩次所打倒的球瓶分數。
         如果擊出Spare則該次計分格的分數需要擊倒10瓶的10分+後面一次丟球所打倒的球瓶分數。
         如果在第10個計分格打出Strike或Spare就會再多出一次丟球的機會,這樣才能決定第10個計分格的分數，換言之第10個計分格最多可以丟3次。
         綜合以上單局最高分為300分,即連續投出12個Strike,而該局又被稱為Perfect Game

commitMessage:
1st-test:定義測試方法TestGutterGame(),測試20次投球全部洗溝的狀況,總得分應為0分<br />
2nd-test:新增測試方法TestAllOnes(),測試20次投球都只得1分,總得分應為20,並TestGutterGame()方法做重構,共通實作邏輯部分<br />
3rd-test:新增測試方法TestOneSpare(),測試只有一次補中以及一次計分格只擊倒部分球瓶(其他16次投球得分均0分)的總得分數<br />
4th-test:新增測試方法TestOneStrke(),測試只有一次全中以及一次計分格(frame)兩次投球各擊倒3跟4個球瓶的情況下(16次投球得分均0分)的總得分數<br />
5th-test:新增測試方法TestPerfectGame(),測試全倒的12次投球中的總得分數(滿分300分)<br />
*在越後面的新增測試中會發現，慢慢修改後的Game Class中的邏輯全不用修改,可以應付所新增的測試方法<br />
