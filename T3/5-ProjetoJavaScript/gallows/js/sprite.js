function createSprite(seletor){
    var el = $(seletor);
    var i = 1
    el.addClass("frame"+i);
    
    function nextFrame(){
        if (i<=9){
            el.removeClass("frame"+i).addClass("frame"+(++i));
            console.log(i);
        }
    }
    
    function reset (){
        
        el.removeClass("frame"+i).addClass("frame"+1);
        i=1;
    }
    function isFinished(){
        return !(i<=9);
    }
    
    return{
        nextFrame: nextFrame,
        reset: reset,
        isFinished: isFinished
    }
    
}