<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\User;


class UserHandler extends Controller
{
    private $apikey = '&ZLJ6ce6mUB45^NsYsd&$AJYv8TRMZQN';    
    //
    public function CreateUser(Request $request){
        if($request['token'] != $apikey){
            return "API-KEY not valid";
        }
        $user = new User;
        $user->email = $request['email'];
        $user->name = $request['name'];
        $user->hoved = $request['hoved'];
        $user->save();
    }

    public function GetUsers(Request $request){
        if($request['token'] != $apikey){
            return "API-KEY not valid";
        }
        return User::all();
    }
}
