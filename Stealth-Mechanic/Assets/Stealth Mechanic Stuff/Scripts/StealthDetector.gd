extends Area3D
enum DetectState {Unaware,Suspcious,Aware}

# State stuff
@onready var _currentState = DetectState.Unaware;

# Sight Stuff
@export var _sightLine : RayCast3D
@onready var _sightArea := %Area3D as Area3D

# Detection values
var _sightRadiusSquared = 25.0

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass
	
func _on_body_entered(body:Node3D) -> void:
	if global_position.distance_squared_to(body.global_position) >= _sightRadiusSquared:
		# body is in sight radius
		#var player = body as Player
		pass
