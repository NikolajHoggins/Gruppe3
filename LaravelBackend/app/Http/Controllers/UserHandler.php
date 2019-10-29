<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\User;

class UserHandler extends Controller
{
    //
    public function CreateUser(Request $request){
        $user = new User;
        $user->email = $request['email'];
        $user->name = $request['name'];
        $user->hoved = $request['hoved'];
        $user->save();
    }

    public function GetUsers(Request $request){
        return User::all();
    }
}
