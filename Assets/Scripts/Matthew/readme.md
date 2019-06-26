## Listening for events
 
 1. add a GameEventListener to an object

 2. decide if you care who sent it. This should be for all cases that have a 1 : n relationship with the event  

  -  Example: eventraised : listenersWhoRespond

  - if you don't care go to 3

 2.b if you care about who sent it, assign the reference to the sender
 in the Sender field

 3. Assign the response to invoke when that event happens





## Raising events

 1. add a PhysicsTriggerListener to an object

 2. specify the tag this "listener object" will filter


Summary

The GameEvent and Listener Behaviours are intended to seperate

when something happened, //who is the snitch that said it happened
Example: Player jumps he snitches on himself by raising the PlayerJumpedEvent

what to do when something happened //how do we resolve this snitching
Example: The player jumped I will now make the UI do something




